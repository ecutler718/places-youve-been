using Nancy;
using Travel.Objects;
using System.Collections.Generic;

namespace TravelList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
   {
      Get["/"] = _ => {
        return View ["index.cshtml"];
      };
      Get["/places"] = _ => {
        List<Place> allPlaces = Place.GetAll();
        return View["places.cshtml", allPlaces];
      };
      Get["/places/new"] = _ => {
        return View["place_form.cshtml"];
      };
      Post["/places"] = _ => {
        Place newPlace = new Place(Request.Form["new-city"], Request.Form["new-country"]);
        List<Place> allPlaces = Place.GetAll();
        return View["places.cshtml", allPlaces];
      };
      Get["/places/{id}"] = parameters => {
        Place place = Place.Find(parameters.id);
        return View["/place.cshtml", place];
      };
    }
  }
}
