// using System;
// using Autofac;
// using Domain.StaffUser;

// namespace Rules.StaffUser.Registering
// {
//     public class ValidationRules : Module
//     {
//         protected override void Load(ContainerBuilder builder)
//         {
//             builder.RegisterInstance<StaffUserIsRegistered>(IsStaffUserRegistered).As<StaffUserIsRegistered>();
//         }

//         bool IsStaffUserRegistered(Guid staffUserId)
//         {
//             return false;
//         }
//     }
// }
