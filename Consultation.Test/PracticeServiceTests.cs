using System;
using Xunit;
using Consultation.Data.Models;
using Consultation.Data.Security;

using Consultation.Data.Services;

namespace Consultation.Test
{
    public class PracticeServiceTests
    {
        private PracticeService svc;

        public PracticeServiceTests()
        {
            svc = new PracticeService();
            
            // empty data source before each test
            svc.Initialise();
        }



        [Fact]
        public void Patient_AddPatientShouldCreatePatientAndAccount()
        {
            // arrange
            var p = svc.AddPatient("Jameses Conneore", "27 Blammer Road, Georgetown", "connore@mail.net", "password", "+1 2304564789", new DateTime(2000,1,1));
            
            // act
            var patient = svc.GetPatientByEmail("connore@mail.net");

            // assert
            Assert.NotNull(patient); // delete doctor should return true
            Assert.Equal(Role.Patient, patient.User.Role);
        }

        [Fact]
        public void Patient_DeletePatientShouldDeleteUserAccount()
        {
            // arrange
            var p = svc.AddPatient("Jameses Conneore", "27 Blammer Road, Georgetown", "connore@mail.net", "password", "+1 2304564789", new DateTime(2000,1,1));

            // act
            svc.DeletePatient(p.Id);
            var loggedIn = svc.GetPatientByEmail("connore@mail.net");

            //assert
            Assert.Null(loggedIn);
        }

        [Fact]
        public void Patient_GetPatientWithId_ShouldRetrivePatient()
        {
            // arrange
            var p = svc.AddPatient("Jameses Conneore", "27 Blammer Road, Georgetown", "connore@mail.net", "password", "+1 2304564789", new DateTime(2000,1,1));

            // act
            var patient = svc.GetPatientById(p.Id);

            //assert
            Assert.NotNull(patient);
            Assert.Equal(p.Id, patient.Id);
            Assert.Equal(p.User.Name, patient.User.Name);
        }



    }
}
