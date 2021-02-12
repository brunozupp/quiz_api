using Quiz.Business.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Business.Interfaces
{
    public interface INotifier
    {
        bool HasNotification();

        List<Notification> GetNotifications();

        void Handle(Notification notification);
    }
}
