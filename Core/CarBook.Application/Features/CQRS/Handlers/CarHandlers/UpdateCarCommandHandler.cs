﻿using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            values.Tranmission=command.Tranmission;
            values.BrandID=command.BrandID;
            values.BigImageUrl=command.BigImageUrl;
            values.CoverImageUrl=command.CoverImageUrl;
            values.Seat=command.Seat;
            values.Fuel=command.Fuel;
            values.Km=command.Km;
            values.Luggage=command.Luggage;
            values.Model=command.Model;
            await _repository.UpdateAsync(values);
        }
    }
}
