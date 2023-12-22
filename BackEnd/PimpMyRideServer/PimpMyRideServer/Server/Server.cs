using PimpMyRideServer.Data;
using PimpMyRideServer.Handlers;

namespace PimpMyRideServer.Server
{
    public class Server
    {
        public static GarageContext context;

        public void Start(string[] args)
        {
            context = new GarageContext();
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();


            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();


            app.MapControllers();

            
            BackupHandler.ExecuteAtMidnight();

            app.Run();
        }
    }
}
