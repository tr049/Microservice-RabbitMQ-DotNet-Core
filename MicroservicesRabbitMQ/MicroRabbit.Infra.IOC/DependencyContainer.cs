using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            /* Event Bus */
            serviceCollection.AddTransient<IEventBus, RabbitMQBus>();

            serviceCollection.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            /* Data (Providers) */
            serviceCollection.AddTransient<BankingDbContext>();
            serviceCollection.AddTransient<IAccountRepository, AccountRepository>();

            /* Application Services */
            serviceCollection.AddTransient<IAccountService, AccountService>();
        }
    }
}