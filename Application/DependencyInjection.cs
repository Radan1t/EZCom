﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Application.Common.DTO;
using Application.Common.Validators;

namespace EZCom.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddScoped<IValidator<UserDTO>, RegistrationValidator>();

            return services;
        }
    }
}
