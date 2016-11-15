using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Threading;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Runtime.Internal;
using System.Collections.Generic;
using Amazon.Util;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DataModel;

namespace Scripts {
	public class LoginToDB : MonoBehaviour {
		// initializing variables for strign and game objects
		public Button login; 
		public string username;
		public string password;
		public int userID; 
		public bool answer; 
		public Text resultText; 
		public GameObject InputFieldUsername; 
		public GameObject InputFieldPassword;
		InputField inputUsername; 
		InputField inputPassword;

		// initializing a tabel players
		private static Table playersTable; 

		// initializing the client
		private IAmazonDynamoDB _client; 

		// Use this for initialization
		void Start () {  
			login.onClick.AddListener (loginListener); 
		}

		public void loginListener(){
			inputUsername = InputFieldUsername.GetComponent<InputField> (); 
			inputPassword = InputFieldPassword.GetComponent<InputField> ();
			username = inputUsername.text; 
			password = inputPassword.text;  
			loadPlayersTable (); 
		}

		public void loadPlayersTable(){
			//resultText.text = "\n***LoadTable***";
			Table.LoadTableAsync (_client, "Players", (loadTableResults) => {
				if (loadTableResults.Exception != null) {
					resultText.text += "\n Failed to load Players table"; 
				} else {
					playersTable = loadTableResults.Result;
					GetPlayersTable(); 
				}
			});
		}

		public static void GetPlayersTable(){
			
		}

		public bool checkLogin(string user, string pass){
			bool check = true; 

			return check; 
		}

		[DynamoDBTable("Players")]
		public class players {
			[DynamoDBHashKey]
			public int ID{ get; set; }
			[DynamoDBProperty]
			public string username{ get; set; }
			[DynamoDBProperty]
			public string password{ get; set; }
		}
	}
}
