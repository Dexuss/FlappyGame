using Game.FacebookIntegration;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Installers
{
    public class FacebookIntegrationSystemFacade : IFacebookIntegrationSystemFacade
    {
        private readonly IFacebookIntegrationSystem facebookIntegrationSystem;

        public FacebookIntegrationSystemFacade(IFacebookIntegrationSystem facebookIntegrationSystem)
        {
            this.facebookIntegrationSystem = facebookIntegrationSystem;
        }

        public void Initialize()
        {
            facebookIntegrationSystem.Initialize();
        }

        public void Login()
        {
            facebookIntegrationSystem.Login();
        }

        public void Logout()
        {
            facebookIntegrationSystem.Logout();
        }

        public void Share()
        {
            facebookIntegrationSystem.Share();
        }
    }
}