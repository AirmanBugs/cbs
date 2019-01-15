/*---------------------------------------------------------------------------------------------
 *  Copyright (c) The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

// using System;
// using Dolittle.Events;

// namespace Events.StaffUser
// {
//     public class PhoneNumberRemovedFromSystemConfigurator : IEvent
//     {
//         public Guid StaffUserId { get; set; }
//         public string PhoneNumber { get; set; }

//         public PhoneNumberRemovedFromSystemConfigurator(Guid staffUserId, string phoneNumber)
//         {
//             StaffUserId = staffUserId;
//             PhoneNumber = phoneNumber;
//         }
//     }

//     public class PhoneNumberRemovedFromDataCoordinator : IEvent
//     {
//         public Guid StaffUserId { get; set; }
//         public string PhoneNumber { get; set; }

//         public PhoneNumberRemovedFromDataCoordinator(Guid staffUserId, string phoneNumber)
//         {
//             StaffUserId = staffUserId;
//             PhoneNumber = phoneNumber;
//         }
//     }

//     public class PhoneNumberRemovedFromDataOwner : IEvent
//     {
//         public Guid StaffUserId { get; set; }
//         public string PhoneNumber { get; set; }

//         public PhoneNumberRemovedFromDataOwner(Guid staffUserId, string phoneNumber)
//         {
//             StaffUserId = staffUserId;
//             PhoneNumber = phoneNumber;
//         }
//     }

//     public class PhoneNumberRemovedFromDataVerifier : IEvent
//     {
//         public Guid StaffUserId { get; set; }
//         public string PhoneNumber { get; set; }

//         public PhoneNumberRemovedFromDataVerifier(Guid staffUserId, string phoneNumber)
//         {
//             StaffUserId = staffUserId;
//             PhoneNumber = phoneNumber;
//         }
//     }
// }