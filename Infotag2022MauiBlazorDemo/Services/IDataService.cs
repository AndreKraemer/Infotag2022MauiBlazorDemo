using Infotag2022MauiBlazorDemo.Models;
namespace Infotag2022MauiBlazorDemo.Services;

public interface IDataService
{
    Session GetSession(int id);
    IEnumerable<Session> GetSessions();
    Speaker GetSpeaker(int id);
    IEnumerable<Speaker> GetSpeakers();
}