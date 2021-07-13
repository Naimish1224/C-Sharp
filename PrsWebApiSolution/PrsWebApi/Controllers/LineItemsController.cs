using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrsWebApi.Data;
using PrsWebApi.Models;

namespace PrsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineItemsController : ControllerBase
    {
        private readonly PrsWebApiContext _context;

        public LineItemsController(PrsWebApiContext context)
        {
            _context = context;
        }

        // GET: api/LineItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LineItem>>> GetLineItems()
        {
            return await _context.LineItems.ToListAsync();
        }



        // GET: api/LineItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LineItem>> GetLineItem(int id)
        {
            var lineItem = await _context.LineItems.FindAsync(id);

            if (lineItem == null)
            {
                return NotFound();
            }

            return lineItem;
        }
        // GET: api/LineItems/LineItemsPr
        [HttpGet("line-items/lines-for-pr/{id}")]
        public async Task<ActionResult<IEnumerable<LineItem>>> GetLineItemsForPr(int id)
        {
            return await _context.LineItems.Where(p => p.RequestID == id).ToListAsync();
        }


        // PUT: api/LineItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLineItem(int id, LineItem lineItem)
        {
            if (id != lineItem.ID)
            {
                return BadRequest();
            }

            _context.Entry(lineItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            await RecalculateTotal(lineItem.RequestID);
            return NoContent();
        }

        // POST: api/LineItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LineItem>> PostLineItem(LineItem lineItem)
        {
            _context.LineItems.Add(lineItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLineItem", new { id = lineItem.ID }, lineItem);
        }

        // DELETE: api/LineItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LineItem>> DeleteLineItem(int id)
        {
            var lineItem = await _context.LineItems.FindAsync(id);
            if (lineItem == null)
            {
                return NotFound();
            }

            _context.LineItems.Remove(lineItem);
            await _context.SaveChangesAsync();

            return lineItem;
        }

        private bool LineItemExists(int id)
        {
            return _context.LineItems.Any(e => e.ID == id);
        }

        //recalculate total
        public async Task RecalculateTotal(int requestID)
        {
            var request = await _context.Requests.FindAsync(requestID);
            request.Total = (from l in _context.LineItems
                             join p in _context.Products on l.ProductID equals p.ID
                             where l.RequestID == requestID
                             select new { Total = l.Quantity * p.Price })
                             .Sum(x => x.Total);
            var rc = await _context.SaveChangesAsync();
            if (rc != 1) throw new Exception("Error recalculating total.");
            
        }






    }
}
