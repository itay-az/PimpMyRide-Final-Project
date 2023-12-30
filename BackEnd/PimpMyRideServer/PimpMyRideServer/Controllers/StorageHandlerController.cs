using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Controllers
{
    // base route controller for storage that inherits from GarageController
    [Route("/StorageHandler")]
    [ApiController]
    
    //cars controllers
    public class StorageHandlerController : GarageController
    {
        // asigning the handler inside the constructor
        public StorageHandlerController() 
        {
            this.handler = new StorageHandler();
        }

        // create a new car with manufacture and model
        [HttpPost]
        public ActionResult CreateManufactureWithModel([FromBody] CreateManufactureAndModelRequest request)
        {
            return ((StorageHandler)handler).HandleCreate(request);
        }

        // get request for retrieving all models by the manufacture name
        [HttpGet("{manufactureName}")]
        public ActionResult GetModelsByManufactureName(string manufactureName)
        {
            return ((StorageHandler)handler).HandlGetById(manufactureName);
        }

        // get request for retrieving all models and manufactures
        [HttpGet]
        public ActionResult GetAllManufacturesAndModels()
        {
            return ((StorageHandler)handler).HandleGet();
        }

        // get request for retrieving all manufactures
        [HttpGet("getManufactures")]
        public ActionResult GetManufactures()
        {
            return ((StorageHandler)handler).HandleGetManufacture();
        }

        // delete request for specific model
        [HttpDelete("removeModel/{manufactureName}/{modelName}")]
        public ActionResult DeleteModel(string modelName,string manufactureName)
        {
            return ((StorageHandler)handler).HandleDelete(manufactureName, modelName);
        }
        
        /* from here on down will be controllers that regards the storage and warehouse */
        

        // post request for creating new part
        [HttpPost("createNewPart")]
        public ActionResult createNewPart([FromBody] Part request)
        {
            return ((StorageHandler)handler).HandleCreatePart(request);
        }
        // get request for retriving all parts
        [HttpGet("getParts")]
        public ActionResult GetParts()
        {
            return ((StorageHandler)handler).HandleGetParts();
        }

        // get request for retriving a specific part
        [HttpGet("getPart/{partId}")]
        public ActionResult GetPartById(string partId)
        {
            return ((StorageHandler)handler).HandleGetPartById(partId);
        }

        // put request for updating a specific part given string id
        [HttpPut("updatePart/{partId}")]
        public ActionResult UpdatePartById(string partId ,[FromBody] Part part) 
        {
            return ((StorageHandler)handler).HandleUpdatePartById(partId, part);
        }

        // delete request for deleting a specific part
        [HttpDelete("deletePart/{partId}")]
        public ActionResult DeletePartById(string partId)
        {
            return ((StorageHandler)handler).HandleDeletePartById(partId);
        }

        // get request for searching part given parameters
        [HttpGet("searchPart/{searchParameter}")]
        public ActionResult SearchPartByParameter(string searchParameter)
        {
            return ((StorageHandler)handler).HandleSearchByParameter(searchParameter);
        }



        /* from here on down will be controllers that regards the suppliers */

        // post request for creating a new supplier
        [HttpPost("newSupplier")]
        public ActionResult CreateSupplier([FromBody] Suppliers supplier)
        {
            return ((StorageHandler)handler).HandleCreateSupplier(supplier);
        }

        // get request for retriving all suppliers
        [HttpGet("getAllSuppliers")]
        public ActionResult GetAllSuppliers()
        {
            return ((StorageHandler)handler).HandleGetAllSuppliers();
        }

        // get request for retriving a specific supplier given a string id
        [HttpGet("getSupplierById/{supplierId}")]
        public ActionResult GetSupplierById(string supplierId)
        {
            return ((StorageHandler)handler).HandleGetSupplierById(supplierId);
        }

        // put request for updating a specific supplier
        [HttpPut("updateSupplier/{supplierId}")]
        public ActionResult UpdateSupplierById(string supplierId, [FromBody] Suppliers supplier)
        {
            return ((StorageHandler)handler).HandleUpdateSupplierById(supplierId, supplier);
        }

        // delete request for deleting a specific supplier
        [HttpDelete("deleteSupplierById/{supplierId}")]
        public ActionResult DeleteSupplierById(string supplierId) 
        {
            return ((StorageHandler)handler).HandleDeleteSupplierById(supplierId);
        }

        /* from here on down will be controllers that regards the orders */

        // post request to create a new order
        [HttpPost("newOrder")]
        public ActionResult createOrder([FromBody] CreateNewOrderRequest order)
        {
            return ((StorageHandler)handler).HandleCreateOrder(order);
        }

        // get request for retriving all orders
        [HttpGet("getAllOrders")]
        public ActionResult GetAllOrders()
        {
            return (((StorageHandler)handler).HandleGetAllOrders());
        }

        // get request for retriving a specific order given an id
        [HttpGet("getOrderById/{orderId}")]
        public ActionResult GetOrderById(int orderId)
        {
            return (((StorageHandler)handler).HandleGetOrderById(orderId));
        }

        // delete request for deleting a specific order 
        [HttpDelete("deleteOrderById/{orderId}")]
        public ActionResult HandleDeleteOrderById(int orderId)
        {
            return ((StorageHandler)handler).HandleDeleteOrderById(orderId);
        }
        


    }
}
