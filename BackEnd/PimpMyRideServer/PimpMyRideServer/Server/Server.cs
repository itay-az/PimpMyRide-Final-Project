using PimpMyRideServer.Data;
using PimpMyRideServer.Handlers;

namespace PimpMyRideServer.Server
{
    public class Server
    {
        // creating a static property of the database context
        public static GarageContext context;


        // a function to start the server
        public void Start(string[] args)
        {
            // creatin a new instant of the database context
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

            // function for backup every day at midnight
            OthersHandler.ExecuteAtMidnight();

            app.Run();
        }
    }
}