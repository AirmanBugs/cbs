// using System;
// using Dolittle.Events;

// namespace Events.StaffUser.Registration
// {
//     public class NewUserRegistered : IEvent
//     {
//         public Guid StaffUserId { get; set;  }
//         public string FullName { get; set;  }
//         public string DisplayName { get; set; }
//         public string Email { get; set; }   

//         public DateTimeOffset RegisteredAt { get; set; }

//         public NewUserRegistered(Guid staffUserId, string fullname, string displayName, string email, DateTimeOffset registeredAt)
//         {
//             StaffUserId = staffUserId;
//             FullName = fullname;
//             DisplayName = displayName;
//             Email = email;
//             RegisteredAt = registeredAt;
//         }
//     }
// }