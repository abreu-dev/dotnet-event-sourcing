using MediatR;
using Supply.Domain.Events.VehicleEvents;
using Supply.Domain.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Supply.Infra.Data.EventHandlers
{
    public class VehicleEventHandler : 
        INotificationHandler<VehicleAddedEvent>,
        INotificationHandler<VehicleUpdatedEvent>,
        INotificationHandler<VehicleRemovedEvent>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleEventHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task Handle(VehicleAddedEvent notification, CancellationToken cancellationToken)
        {
            var vehicle = await _vehicleRepository.GetById(notification.AggregateId);
        }

        public async Task Handle(VehicleUpdatedEvent notification, CancellationToken cancellationToken)
        {
            var vehicle = await _vehicleRepository.GetById(notification.AggregateId);
        }

        public async Task Handle(VehicleRemovedEvent notification, CancellationToken cancellationToken)
        {
            var vehicle = await _vehicleRepository.GetById(notification.AggregateId);
        }
    }
}
