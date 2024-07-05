using DemoTrip.Core.UseCases;

namespace DemoTrip.Core.Interfaces
{
    public interface ISearchFlightUseCase
    {
        SearchFlightResponseDto Execute(SearchFlightRequestDto request);
    }
}