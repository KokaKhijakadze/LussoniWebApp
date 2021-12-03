using LussoniWebApp.Shared.Data;
using LussoniWebApp.Shared.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LussoniWebApp.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    public readonly ApplicationDbContext dbContext;
    public EmployeeController(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpGet]
    public async Task<ActionResult<List<Employee>>> Get()
    {
        return await dbContext.Employees.ToListAsync();

    }
    [HttpPost]
    public async Task<ActionResult> Post(Employee employee)
    {
        dbContext.Add(employee);
        await dbContext.SaveChangesAsync();
        return new CreatedAtRouteResult("GetEmployee", new { id = employee.ID }, employee);
        
    }
    [HttpPut]
    public async Task<ActionResult> Put(Employee employee)
    {
        dbContext.Entry(employee).State = EntityState.Modified;
        await dbContext.SaveChangesAsync();
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var employee = new Employee { ID = id };
        dbContext.Remove(employee);
        await dbContext.SaveChangesAsync();
        return NoContent();
    }
}
