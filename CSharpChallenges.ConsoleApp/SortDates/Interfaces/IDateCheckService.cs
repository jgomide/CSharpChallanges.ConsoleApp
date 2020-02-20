using System;

namespace SortDates.ConsoleApp
{
    interface IDateCheckService
    {
        void SortDates(DateTime[] datesToCompare);
    }
}