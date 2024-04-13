using PatrolPal.Model;

namespace PatrolPal.DTO
{
    public class DistrictsDetailsRes
    {
        public List<CameraLocation>? Camera { get; set; }
        public List<PoliceStations>? Stations { get; set; }
    }
}
