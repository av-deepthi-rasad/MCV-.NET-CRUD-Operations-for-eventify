using Microsoft.AspNetCore.Mvc;
using Eventify_web_api.Models;

namespace Eventify_web_api.Controllers
{
    public class EventsController : Controller
    {


        public IActionResult Index()
        {
            var events = EventsRepository.GetEvents();
            return View(events);
        }



        public IActionResult Edit(int? id)
        {
            var eevent = EventsRepository.GetEventById(id.HasValue?id.Value:0);
            return View(eevent);
        }

        [HttpPost]
        public IActionResult Edit(Event eevent)
        {
            if(ModelState.IsValid)
            {
                EventsRepository.UpdateEvent(eevent.EventId, eevent);
                return RedirectToAction(nameof(Index));
            }
            return View(eevent);
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Event eevent) 
        { 
            if(ModelState.IsValid)
            {
                EventsRepository.AddEvent(eevent);
                return RedirectToAction(nameof(Index));
            }
            return View(eevent);
        }

        public IActionResult Delete(int eventId)
        {
            EventsRepository.DeleteEvent(eventId);
            return RedirectToAction(nameof(Index));

        }


    }
}
