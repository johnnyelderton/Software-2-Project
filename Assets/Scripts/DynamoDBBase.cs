using UnityEngine;
using System.Collections;
using Amazon.DynamoDBv2;
using Amazon.CognitoIdentity;
using Amazon.Runtime;
using Amazon;

namespace AssemblyCSharp
{
	public class DynamoDBBase : MonoBehaviour
	{
		public string IdentityPoolID = "";
		public string CognitoPoolRegion = RegionEndpoint.USEast1.SystemName;
		public string DynamoRegion = RegionEndpoint.USEast1.SystemName;
		private static IAmazonDynamoDB _ddbClient; 
		private AWSCredentials _credentials; 

		private RegionEndpoint _CongnitoPoolRegion{
			get{
				return RegionEndpoint.GetBySystemName (CognitoPoolRegion); 
			}
		}

		private RegionEndpoint _DynamoRegion{
			get{
				return RegionEndpoint.GetBySystemName (DynamoRegion); 
			}
		}

		private AWSCredentials credentials{
			get{
				if (_credentials == null) {
					_credentials = new CognitoAWSCredentials (IdentityPoolID, _CongnitoPoolRegion);
				}
				return _credentials; 
			}
		}

		protected IAmazonDynamoDB Client{
			get{
				if (_ddbClient == null) {
					_ddbClient = new AmazonDynamoDBClient (credentials, _DynamoRegion); 
				}
				return _ddbClient; 
			}
		}
	}
}

