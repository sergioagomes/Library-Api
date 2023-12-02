﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Library.Models;
using static Library.Data.Dtos.AddressDto;
using Library.Data;

namespace MoviesAPi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private MysqlContext _context;
        private IMapper _mapper;

        public AddressController(MysqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddAddress([FromBody] CreateAddressDto addressDto)
        {
            Address address = _mapper.Map<Address>(addressDto);
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAddressById), new { Id = address.Id }, address);
        }

        [HttpGet]
        public IEnumerable<ReadAddressDto> GetAddress()
        {
            return _mapper.Map<List<ReadAddressDto>>(_context.Addresses);
        }

        [HttpGet("{id}")]
        public IActionResult GetAddressById(int id)
        {
            Address address = _context.Addresses.FirstOrDefault(address => address.Id == id);
            if (address != null)
            {
                ReadAddressDto addressDto = _mapper.Map<ReadAddressDto>(address);

                return Ok(addressDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAddress(int id, [FromBody] UpdateAddressDto enderecoDto)
        {
            Address address = _context.Addresses.FirstOrDefault(address => address.Id == id);
            if (address == null)
            {
                return NotFound();
            }
            _mapper.Map(enderecoDto, address);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaEndereco(int id)
        {
            Address address = _context.Addresses.FirstOrDefault(address => address.Id == id);
            if (address == null)
            {
                return NotFound();
            }
            _context.Remove(address);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
