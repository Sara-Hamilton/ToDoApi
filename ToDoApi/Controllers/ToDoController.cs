using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDoApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/todo")]
    [ApiController]
    public class ToDoController : Controller
    {
        private readonly ToDoContext _context;

        public ToDoController(ToDoContext context)
        {
            _context = context;

            if (_context.ToDoItems.Count() == 0)
            {
                // Create a new ToDoItem if collection is empty,
                // Which means you can't delete all ToDoItems.
                _context.ToDoItems.Add(new ToDoItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        // GET /api/todo
        [HttpGet]
        public ActionResult<List<ToDoItem>> GetAll()
        {
            return _context.ToDoItems.ToList();
        }

        // GET /api/todo/{id}
        [HttpGet("{id}", Name = "GetToDo")]
        public ActionResult<ToDoItem> GetById(long id)
        {
            var item = _context.ToDoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // POST /api/todo
        // tripple slashes add comments to swagger UI
        /// <summary>
        /// Creates a TodoItem.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "name": "Item1",
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
        /// <param name="item"></param>
        /// <returns>A newly created TodoItem</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult Create(ToDoItem item)
        {
            _context.ToDoItems.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetToDo", new { id = item.Id }, item);
        }

        // PUT /api/todo/{id}
        [HttpPut("{id}")]
        public IActionResult Update(long id, ToDoItem item)
        {
            var toDo = _context.ToDoItems.Find(id);
            if (toDo == null)
            {
                return NotFound();
            }

            toDo.IsComplete = item.IsComplete;
            toDo.Name = item.Name;

            _context.ToDoItems.Update(toDo);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE /api/todo/{id}
        // triple slashes display comments in swagger UI
        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        /// <param name="id"></param> 
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var toDo = _context.ToDoItems.Find(id);
            if (toDo == null)
            {
                return NotFound();
            }

            _context.ToDoItems.Remove(toDo);
            _context.SaveChanges();
            return NoContent();
        }

     }
}
