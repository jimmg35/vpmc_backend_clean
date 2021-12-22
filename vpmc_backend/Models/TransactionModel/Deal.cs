using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vpmc_backend.Models
{
    public class Deal
    {
        public string Id { get; set; }
        public string NonMetroLandUseDistrict { get; set; }
        public short? LandTransactionAmount { get; set; }
        public short? BuildingTransactionAmount { get; set; }
        public short? ParkTransactionAmount { get; set; }
        public short? TotalFloorNumber { get; set; }
        public string BuildingMaterial { get; set; }
        public string TransactionSign { get; set; }
        public string NonMetroLandUse { get; set; }
        public string TransactionDate { get; set; }
        public string CompletionDate { get; set; }
        public string ShiftingLevel { get; set; }
        public int? ParsedShiftingLevel { get; set; }
        public string BuildingState { get; set; }
        public string ParkCategory { get; set; }
        public string MainUse { get; set; }
        public string Address { get; set; }
        public string LandUse { get; set; }
        public string Town { get; set; }
        public string Note { get; set; }
        public float? BuildingShiftingArea { get; set; }
        public float? LandShiftingArea { get; set; }
        public float? MainBuildingArea { get; set; }
        public float? ParkShiftingArea { get; set; }
        public float? SubBuildingArea { get; set; }
        public int? ParkTotalPrice { get; set; }
        public float? BelconyArea { get; set; }
        public int? TotalPrice { get; set; }
        public float? UnitPrice { get; set; }
        public short? BathNumber { get; set; }
        public short? BedNumber { get; set; }
        public short? HallNumber { get; set; }
        public string HasManageOrganization { get; set; }
        public string HasCompartmented { get; set; }
        public string HasElevator { get; set; }
        public int? CoordinateX { get; set; }
        public int? CoordinateY { get; set; }
    }
}
