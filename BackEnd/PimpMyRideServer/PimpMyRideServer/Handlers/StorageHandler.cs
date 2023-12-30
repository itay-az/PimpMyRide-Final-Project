using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Entity;
using Microsoft.EntityFrameworkCore;
using PimpMyRideServer.Data;
using PimpMyRideServer.Handlers.Interfaces;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.Requests;
using PimpMyRideServer.Server.Responses;
using Remotion.Linq.Clauses;

namespace PimpMyRideServer.Handlers
{
    // storage handler that handles all the http requests regarding the clients
    public class StorageHandler :CreateHandler, GetByIdHandler, GetHandler
    {
        // function that handles the create http request, routing from the controller,
        // it recieves a create request, checks for duplicates,
        // if everything checks out it creates an entity according to the request and returns status 200,
        // otherwise it returns a customized failure response
        public ActionResult HandleCreate(Request request)
        {
            CreateManufactureAndModelRequest createManufactureAndModelRequest = (CreateManufactureAndModelRequest)request;
            Manufacture manufacture = new Manufacture();
            manufacture.manufacturerName = createManufactureAndModelRequest.manufacturerName;
            Model model = new Model();
            model.manufacturerName = createManufactureAndModelRequest.manufacturerName;
            model.model = createManufactureAndModelRequest.modelName;

            var manu = Server.Server.context.Manufacture.SingleOrDefault(m => m.manufacturerName == manufacture.manufacturerName);
            if(manu != null)
            {
                var modelDb = Server.Server.context.Model.SingleOrDefault(m =>m.manufacturerName == manufacture.manufacturerName && m.model == model.model);
                if(modelDb != null)
                {
                    return ErrorHandler.onFailure("Model not found", "Not found");
                }
                Server.Server.context.Model.Add(model);
                Server.Server.context.SaveChanges();
                return new StatusCodeResult(StatusCodes.Status200OK);
            }
            else
            {
                Server.Server.context.Manufacture.Add(manufacture);
                Server.Server.context.Model.Add(model);
                Server.Server.context.SaveChanges();
                return new StatusCodeResult(StatusCodes.Status200OK);
            }
        }

        // function that handles the create http request, routing from the controller,
        // it recieves an entity, checks for duplicates,
        // if everything checks out it creates an entity according to the request and returns status 200,
        // otherwise it returns a customized failure response
        public ActionResult HandleCreatePart(Part part)
        {

            Part partAdded = new Part
            {
                partId = part.partId,
                partName = part.partName,
                price = part.price,
                quantity = part.quantity,
            };
            Server.Server.context.Part.Add(partAdded);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);

        }

        // function that handles the get http request, routing from the controller,
        // it recieves an id and retrive the relevant entity
        // if everything checks out retrives the requested entity which have the same id
        // otherwise it returns a customized failure response
        public ActionResult HandlGetById(string id)
        {
            var manufacture = Server.Server.context.Manufacture.Find(id);
            if(manufacture == null)
            {
                return ErrorHandler.onFailure("Manufacture not found", "Not found");
            }

            var models = Server.Server.context.Model.Where(model => model.manufacturerName.Equals(id)).ToList();
            
            if(models == null)
            {
                return ErrorHandler.onFailure("Model not found", "Not found");
            }
            JsonResult jsonResults = new JsonResult(models);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;
        }

        // function that handles the get http request, routing from the controller,
        // if everything checks out it retrives all the relevant information and a status 200
        // otherwise it returns a customized failure response
        public ActionResult HandleGet()
        {
            var models = Server.Server.context.Model;
            if (models == null)
            {
                return ErrorHandler.onFailure("Model not found", "Not found");
            }


            JsonResult jsonResults = new JsonResult(models);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;
        }

        // function that handles the get http request, routing from the controller,
        // if everything checks out it retrives all the relevant information and a status 200
        // otherwise it returns a customized failure response
        public ActionResult HandleGetManufacture()
        {
            var manufactures = Server.Server.context.Manufacture;
            if (manufactures == null || manufactures.Count() == 0)
            {
                return ErrorHandler.onFailure("Manufactures not found", "Not found");
            }


            JsonResult jsonResults = new JsonResult(manufactures);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;
        }

        // function that handles the delete http request, routing from the controller,
        // it recieves an manufacture name and modelname
        // if everything checks out it deletes the specific car
        // otherwise it returns a customized failure response
        public ActionResult HandleDelete(string manufactureName,string modelName)
        {
            var manufacture = Server.Server.context.Manufacture.SingleOrDefault(manu => manu.manufacturerName.Equals(manufactureName));
            var model = Server.Server.context.Model.SingleOrDefault(model => model.model.Equals(modelName) && model.manufacturerName.Equals(manufactureName));

            if (manufacture == null)
            {
                return ErrorHandler.onFailure("Manufactures not found", "Not found");
            }

            else if (model == null)
            {
                return ErrorHandler.onFailure("Model not found", "Not found");
            }
            Server.Server.context.Model.Remove(model);
            Server.Server.context.SaveChanges();

            List<Model> models = Server.Server.context.Model.Where(model => model.manufacturerName.Equals(manufactureName)).ToList();

            if(models.Count  <= 0) 
            {
                Server.Server.context.Manufacture.Remove(manufacture);
                Server.Server.context.SaveChanges();
            }
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        // function that handles the get http request, routing from the controller,
        // if everything checks out it retrives all the relevant information and a status 200
        // otherwise it returns a customized failure response
        public ActionResult HandleGetParts()
        {

            var parts = Server.Server.context.Part.ToList();

            if (parts == null || parts.Count() == 0)
            {
                return ErrorHandler.onFailure("Parts not found", "Not found");
            }
            List<PartResponse> response = new List<PartResponse>();
            foreach (Part p in parts)
            {
                if (p.quantity == 0)
                {
                    continue;
                }
                else
                {
                    response.Add(new PartResponse
                    {
                        partId = p.partId,
                        partName = p.partName,
                        price = p.price,
                        quantity = p.quantity
                    });
                }
            }
            JsonResult jsonResult = new JsonResult(response);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        // function that handles the get http request, routing from the controller,
        // it recieves an id as a parameter
        // if everything checks out it retrives the requested entity which have the same id
        // otherwise it returns a customized failure response
        public ActionResult HandleGetPartById(string partId)
        {
            var part = Server.Server.context.Part.SingleOrDefault(p => p.partId == partId);

            if (part == null)
            {
                return ErrorHandler.onFailure("Part not found", "Not found");
            }

            JsonResult jsonResult = new JsonResult(part);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        // function that handles the put http request, routing from the controller,
        // it recieves an id as a parameter and an entity
        // if everything checks out it updates the requested entity which have the same id and return it with a status code of 200
        // otherwise it returns a customized failure response
        public ActionResult HandleUpdatePartById(string partId, Part partFromBody)
        {
            var part = Server.Server.context.Part.SingleOrDefault(p => p.partId == partId);

            if(part == null)
            {
                return ErrorHandler.onFailure("Part not found", "Not found");
            }

            part.price = partFromBody.price;
            part.partName = partFromBody.partName;
            part.quantity = partFromBody.quantity;

            Server.Server.context.Part.Update(part);
            Server.Server.context.SaveChanges();
            JsonResult jsonResult = new JsonResult(part);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        // function that handles the delete http request, routing from the controller,
        // it recieves an id as a parameter
        // if everything checks out it deletes the requested entity which have the same id
        // otherwise it returns a customized failure response
        public ActionResult HandleDeletePartById(string partId)
        {
            var part = Server.Server.context.Part.SingleOrDefault(p => p.partId == partId);

            if (part == null)
            {
                return ErrorHandler.onFailure("Part not found", "Not found");
            }
            Server.Server.context.Part.Remove(part);
            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);


        }

        // function that handles the get http request, routing from the controller,
        // it recieves a string as a parameter
        // if everything checks out it searches the requested entity which have the some of or the whole string in it
        // otherwise it returns a customized failure response
        public ActionResult HandleSearchByParameter(string searchParameter)
        {
            using(var context = new GarageContext())
            {

                if(searchParameter == String.Empty)
                {
                    return HandleGetParts();
                }

                var parts = context.Part
                    .Where(e => e.partName.Contains( searchParameter))
                    .ToList();

                if(parts == null)
                {
                    return ErrorHandler.onFailure("Part not found", "Not found");
                }

                JsonResult jsonResult = new JsonResult(parts);
                jsonResult.StatusCode = StatusCodes.Status200OK;
                return jsonResult;
            }
        }


        // suppliers

        // function that handles the post http request, routing from the controller,
        // it recieves an entity as a parameter
        // if everything checks out it creates the requested entity 
        // otherwise it returns a customized failure response
        public ActionResult HandleCreateSupplier(Suppliers supplier)
        {
            var supplierFromDb = Server.Server.context.Suppliers.SingleOrDefault(s => s.supplierId == supplier.supplierId);
            if(supplierFromDb != null)
            {
                return ErrorHandler.onFailure("Supplier already exist", "Conflict", 409);
            }

            Server.Server.context.Suppliers.Add(supplier);
            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);

        }

        // function that handles the get http request, routing from the controller,
        // if everything checks out it retrives the requested entity
        // otherwise it returns a customized failure response
        public ActionResult HandleGetAllSuppliers()
        {
            var suppliers = Server.Server.context.Suppliers;

            if(suppliers == null)
            {
                return ErrorHandler.onFailure("Suppliers not found", "Not found");
            }

            JsonResult jsonResult = new JsonResult(suppliers);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        // function that handles the get http request, routing from the controller,
        // it recieves an id as a parameter
        // if everything checks out it retrives the requested entity which have the same id
        // otherwise it returns a customized failure response
        public ActionResult HandleGetSupplierById(string supplierId)
        {
            var supplier = Server.Server.context.Suppliers.SingleOrDefault(s=> s.supplierId == supplierId);

            if (supplier == null)
            {
                return ErrorHandler.onFailure("Supplier not found", "Not found");
            }

            JsonResult jsonResult = new JsonResult(supplier);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        // function that handles the put http request, routing from the controller,
        // it recieves an id as a parameter and an entity
        // if everything checks out it updates the requested entity which have the same id
        // otherwise it returns a customized failure response
        public ActionResult HandleUpdateSupplierById(string supplierId, Suppliers supplierFromBody)
        {
            var supplier = Server.Server.context.Suppliers.SingleOrDefault(s => s.supplierId == supplierId);

            if (supplier == null)
            {
                return ErrorHandler.onFailure("Supplier not found", "Not found");
            }

            supplier.supplierId = supplierFromBody.supplierId;
            supplier.supplierName = supplierFromBody.supplierName;
            supplier.supplierAddress = supplierFromBody.supplierAddress;
            supplier.supplierPhone = supplierFromBody.supplierPhone;
            supplier.supplierEmail = supplierFromBody.supplierEmail;
            supplier.orders = supplierFromBody.orders;


            Server.Server.context.Suppliers.Update(supplier);
            Server.Server.context.SaveChanges();
            JsonResult jsonResult = new JsonResult(supplier);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        // function that handles the delete http request, routing from the controller,
        // it recieves an id as a parameter
        // if everything checks out it deletes the requested entity which have the same id
        // otherwise it returns a customized failure response
        public ActionResult HandleDeleteSupplierById(string supplierId)
        {
            var suppliers = Server.Server.context.Suppliers.SingleOrDefault(s => s.supplierId == supplierId);

            if(suppliers == null)
            {
                return ErrorHandler.onFailure("Supplier not found", "Not found");
            }

            Server.Server.context.Suppliers.Remove(suppliers);
            Server.Server.context.SaveChanges();

            JsonResult jsonResult = new JsonResult(suppliers);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        // Orders from suppliers

        // function that handles the post http request, routing from the controller,
        // it recieves an entity as a parameter
        // if everything checks out it creates the requested entity which have the same id
        // otherwise it returns a customized failure response
        public ActionResult HandleCreateOrder(CreateNewOrderRequest createNewOrderRequest ) 
        {
            var supplier = Server.Server.context.Suppliers.FirstOrDefault(s => s.supplierName == createNewOrderRequest.supplierName);

            if(supplier == null)
            {
                return ErrorHandler.onFailure("Supplier not found", "Not found");
            }


            Order order = new Order
            {
                parts = createNewOrderRequest.parts,
                supplierName = createNewOrderRequest.supplierName,
            };

            order.calculatePrice();

            supplier.orders.Add(order);
            Server.Server.context.Order.Add(order);
            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        // function that handles the get http request, routing from the controller,
        // if everything checks out it retrives the requested entity
        // otherwise it returns a customized failure response
        public ActionResult HandleGetAllOrders()
        {
            var orders = Server.Server.context.Order.Include("parts");

            if (orders == null || orders.Count() == 0)
            {
                return ErrorHandler.onFailure("Orders not found", "Not found");
            }

            JsonResult jsonResult = new JsonResult(orders);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        // function that handles the get http request, routing from the controller,
        // it recieves an id as a parameter
        // if everything checks out it retrives the requested entity which have the same id
        // otherwise it returns a customized failure response
        public ActionResult HandleGetOrderById(int orderId)
        {
            var order = Server.Server.context.Order.SingleOrDefault(o => o.orderId == orderId);

            if (order == null)
            {
                return ErrorHandler.onFailure("Order not found", "Not found");
            }

            JsonResult jsonResult = new JsonResult(order);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        // function that handles the delete http request, routing from the controller,
        // it recieves an id as a parameter
        // if everything checks out it deletes the requested entity which have the same id
        // otherwise it returns a customized failure response
        public ActionResult HandleDeleteOrderById(int orderId)
        {
            var order = Server.Server.context.Order.SingleOrDefault(o => o.orderId == orderId);

            if (order == null)
            {
                return ErrorHandler.onFailure("Order not found", "Not found");
            }

            Server.Server.context.Order.Remove(order);
            Server.Server.context.SaveChanges();

            JsonResult jsonResult = new JsonResult(order);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        
    }
}
