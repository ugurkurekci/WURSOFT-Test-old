using HumanResourcesModule.Business.Dto;
using HumanResourcesModule.Business.Services.City;
using Microsoft.AspNetCore.Mvc;


namespace HumanResourcesModule.Api.Controllers;

public class CityController : BaseController
{

    private readonly ICityService _cityService;

    public CityController(ICityService cityService)
    {
        _cityService = cityService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        List<CitySelectListDto> result = _cityService.GetList();
        if (result == null)
        {
            return BadRequest();
        }
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {

        CitySelectListDto result = _cityService.GetByID(id);
        if (result == null)
        {
            return BadRequest();
        }

        return Ok(result);
    }
}