namespace PimpMyRideServer.Server.Requests
{
    public class CreateManufactureAndModelRequest : Request
    {
        public string manufacturerName { get; set;}

        public int modelId { get; set; }
        public string modelName { get; set; }

        public CreateManufactureAndModelRequest(string manufacturerName, int modelId, string modelName)
        {
            this.manufacturerName = manufacturerName;
            this.modelId = modelId;
            this.modelName = modelName;
        }

    }
}
