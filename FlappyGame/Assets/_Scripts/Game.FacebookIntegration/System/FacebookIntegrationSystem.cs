using Facebook.Unity;
using Game.Installers;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Game.FacebookIntegration
{
    public class FacebookIntegrationSystem : IFacebookIntegrationSystem
    {
        [Inject]
        private IScoreSystemFacade scoreSystemFacade;

        public void Initialize()
        {
            if (!FB.IsInitialized)
            {
                FB.Init(() =>
                {
                    if (FB.IsInitialized)
                        FB.ActivateApp();
                },
                isGameShown =>
                {
                    if (!isGameShown)
                        Time.timeScale = 0;
                    else
                        Time.timeScale = 1;
                });
            }
            else
            {
                FB.ActivateApp();
            } 
        }

        public void Login()
        {
            var permissions = new List<string>() { "public_profile", "email", "user_friends" };
            FB.LogInWithReadPermissions(permissions);
        }

        public void Logout()
        {
            FB.LogOut();
        }

        public void Share()
        {
            string scoreText = "I've got " + scoreSystemFacade.GetCurrentScore().ToString() + " point!";
            FB.ShareLink(new System.Uri("https://i.ibb.co/py6bRLZ/birdIcon.png"), "My score in FlappyGame!",  scoreText, new System.Uri("https://i.ibb.co/py6bRLZ/birdIcon.png"));
        }
    }
}