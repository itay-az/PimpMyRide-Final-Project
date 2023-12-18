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
    public class StorageHandler :CreateHandler, GetByIdHandler, GetHandler
    {
        private ActionResult onFailure(string message)
        {
            FailureResponse failureResponse = new FailureResponse
            {
                status = false,
                message = message
            };

            JsonResult jsonResult = new JsonResult(failureResponse);
            return jsonResult;
        }
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
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
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
        
        public ActionResult HandleCreatePart(Part part)
        {
            Part partAdded = new Part();
            partAdded.partId = part.partId;
            partAdded.partName = part.partName;
            partAdded.price = part.price;
            partAdded.quantity = part.quantity;

            Server.Server.context.Part.Add(partAdded);
            Server.Server.context.SaveChanges();
            return new StatusCodeResult(StatusCodes.Status200OK);

        }
        
        public ActionResult HandlGetById(string id)
        {
            var manufacture = Server.Server.context.Manufacture.Find(id);
            if(manufacture == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            List<Model> models = Server.Server.context.Model.Where(model => model.manufacturerName.Equals(id)).ToList();
            
            if(models == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }
            JsonResult jsonResults = new JsonResult(models);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;
        }

        public ActionResult HandleGet()
        {
            var models = Server.Server.context.Model;
            if (models == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            
            JsonResult jsonResults = new JsonResult(models);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;
        }
        
        public ActionResult HandleGetManufacture()
        {
            var manufactures = Server.Server.context.Manufacture;
            if (manufactures == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }


            JsonResult jsonResults = new JsonResult(manufactures);
            jsonResults.StatusCode = StatusCodes.Status200OK;
            return jsonResults;
        }

        public ActionResult HandleDelete(string manufactureName,string modelName)
        {
            var manufacture = Server.Server.context.Manufacture.SingleOrDefault(manu => manu.manufacturerName.Equals(manufactureName));
            var model = Server.Server.context.Model.SingleOrDefault(model => model.model.Equals(modelName) && model.manufacturerName.Equals(manufactureName));

            if (manufacture == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            else if (model == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
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


        public ActionResult HandleGetParts()
        {
            using (var context = new GarageContext())
            {
                var parts = context.Part.ToList();
                
                if (parts == null)
                {
                    return new StatusCodeResult(StatusCodes.Status404NotFound);
                }
                List<PartResponse> response = new List<PartResponse>();
                foreach (Part p in parts)
                {
                    if(p.quantity == 0)
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

        }
        
    /*
        public ActionResult HandleAddTicketToPart(int partId, Part partFromBody)
        {
            var part = Server.Server.context.Part.SingleOrDefault(p => p.partId == partId);

            if (part == null)
            {
                return false;
            }

            if(part.quantity < partFromBody.quantity)
            {
                return false;
            }


            foreach (Ticket ticket in partFromBody.tickets)
            {
                part.tickets.Add(ticket);
            }

            Server.Server.context.Part.Update(part);
            Server.Server.context.SaveChanges();
            JsonResult jsonResult = new JsonResult(part);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }
        */
        
        public ActionResult HandleGetPartById(string partId)
        {
            var part = Server.Server.context.Part.SingleOrDefault(p => p.partId == partId);

            if (part == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            JsonResult jsonResult = new JsonResult(part);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        public ActionResult HandleUpdatePartById(string partId, Part partFromBody)
        {
            var part = Server.Server.context.Part.SingleOrDefault(p => p.partId == partId);

            if(part == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
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
        
        public ActionResult HandleDeletePartById(string partId)
        {
            var part = Server.Server.context.Part.SingleOrDefault(p => p.partId == partId);

            if (part == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }
            Server.Server.context.Part.Remove(part);
            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);


        } 


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
                    return onFailure("No parts found");
                }

                JsonResult jsonResult = new JsonResult(parts);
                jsonResult.StatusCode = StatusCodes.Status200OK;
                return jsonResult;
            }
        }


        // suppliers

        public ActionResult HandleCreateSupplier(Suppliers supplier)
        {
            var supplierFromDb = Server.Server.context.Suppliers.SingleOrDefault(s => s.supplierId == supplier.supplierId);
            if(supplierFromDb != null)
            {
                return new StatusCodeResult(StatusCodes.Status409Conflict);
            }

            Server.Server.context.Suppliers.Add(supplier);
            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);

        }

        public ActionResult HandleGetAllSuppliers()
        {
            var suppliers = Server.Server.context.Suppliers;

            if(suppliers == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            JsonResult jsonResult = new JsonResult(suppliers);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        public ActionResult HandleGetSupplierById(string supplierId)
        {
            var supplier = Server.Server.context.Suppliers.SingleOrDefault(s=> s.supplierId == supplierId);

            if (supplier == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            JsonResult jsonResult = new JsonResult(supplier);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        public ActionResult HandleUpdateSupplierById(string supplierId, Suppliers supplierFromBody)
        {
            var supplier = Server.Server.context.Suppliers.SingleOrDefault(s => s.supplierId == supplierId);

            if (supplier == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
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

        public ActionResult HandleDeleteSupplierById(string supplierId)
        {
            var suppliers = Server.Server.context.Suppliers.SingleOrDefault(s => s.supplierId == supplierId);

            if(suppliers == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            Server.Server.context.Suppliers.Remove(suppliers);
            Server.Server.context.SaveChanges();

            JsonResult jsonResult = new JsonResult(suppliers);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }
        
        // Orders from suppliers
        public ActionResult HandleCreateOrder(CreateNewOrderRequest createNewOrderRequest ) 
        {
            var s = Server.Server.context.Suppliers.FirstOrDefault(s => s.supplierName == createNewOrderRequest.supplierName);

            if(s == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            //Order order = new Order(createNewOrderRequest.parts, s.supplierName);

            Order order = new Order
            {
                parts = createNewOrderRequest.parts,
                supplierName = createNewOrderRequest.supplierName,
            };

            order.calculatePrice();

            s.orders.Add(order);
            Server.Server.context.Order.Add(order);
            Server.Server.context.SaveChanges();

            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        public ActionResult HandleGetAllOrders()
        {
            var orders = Server.Server.context.Order.Include("parts");

            if (orders == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            JsonResult jsonResult = new JsonResult(orders);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }
        public ActionResult HandleGetOrderById(int orderId)
        {
            var order = Server.Server.context.Order.SingleOrDefault(o => o.orderId == orderId);

            if (order == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            JsonResult jsonResult = new JsonResult(order);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        public ActionResult HandleDeleteOrderById(int orderId)
        {
            var order = Server.Server.context.Order.SingleOrDefault(o => o.orderId == orderId);

            if (order == null)
            {
                return new StatusCodeResult(StatusCodes.Status404NotFound);
            }

            Server.Server.context.Order.Remove(order);
            Server.Server.context.SaveChanges();

            JsonResult jsonResult = new JsonResult(order);
            jsonResult.StatusCode = StatusCodes.Status200OK;
            return jsonResult;
        }

        
    }
}
