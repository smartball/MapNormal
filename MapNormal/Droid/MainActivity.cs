using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;

namespace MapNormal.Droid
{
    [Activity(Label = "MapNormal", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity,IOnMapReadyCallback
    {
        

        public void OnMapReady(GoogleMap googleMap)
        {
            MarkerOptions markerOptions = new MarkerOptions();
            markerOptions.SetPosition(new LatLng(13.7298956, 100.7771276));

            markerOptions.SetTitle("My Position");

            googleMap.AddMarker(markerOptions);
            googleMap.UiSettings.ZoomControlsEnabled = true;
            googleMap.UiSettings.CompassEnabled = true;
            googleMap.MoveCamera(CameraUpdateFactory.NewLatLngZoom(new LatLng(13.7448301, 100.7226308), 8.0f));
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            MapFragment mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);
        }
    }
}

