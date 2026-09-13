using Microsoft.AspNetCore.Mvc;
using BakuTech.Business.Abstractions.Services;
using BakuTech.Business.DTOs.Orders;

namespace BakuTech.Web.Controllers;

public class OrderController : Controller
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateOrderDto dto)
    {
        try
        {
            var orderId = await _orderService.CreateAsync(dto);

            return Json(new
            {
                success = true,
                orderId
            });
        }
        catch (Exception ex)
        {
            return BadRequest(new
            {
                success = false,
                message = ex.Message
            });
        }
    }

    [HttpGet]
    public async Task<IActionResult> Success(int id)
    {
        var order = await _orderService.GetByIdAsync(id);

        if (order is null)
            return NotFound();

        ViewData["Title"] = "Order Completed";

        return View(order);
    }
}
