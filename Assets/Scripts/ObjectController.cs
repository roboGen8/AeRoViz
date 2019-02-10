//-----------------------------------------------------------------------
// <copyright file="ObjectController.cs" company="Google Inc.">
// Copyright 2014 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

namespace GoogleVR.HelloVR
{
    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.UI;
    using MongoDB.Bson;
    using MongoDB.Driver;
    using System;
    using System.Threading;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    [RequireComponent(typeof(Collider))]
    public class ObjectController : MonoBehaviour
    {
        // private Vector3 startingPosition;
        // private Renderer myRenderer;

        public GameObject toggle;
        public CanvasGroup gazedAtMaterial;
        public const string connectionString = "mongodb://admin:Dasani112@ds145704.mlab.com:45704/aerovizdb";
        public const int Max = 100;
        public const int WaitTime = 3;

        private MongoClient client;
        private MongoServer server;
        private MongoDatabase database;
        private string collectionName;
        public GameObject searchRes, map;
        public GameObject res;
        public Material red, green;
        public string[][] zzz;
        public GameObject holo, mainscreen, plane;

        void Start() {
            client = new MongoClient(connectionString);
            server = client.GetServer();
            database = server.GetDatabase("aerovizdb");
            SetGazedAt(false);
            // var collection = database.GetCollection<Defective2018>("defective2018");
            // var builder = Builders<BsonDocument>.Filter;
            // // IMongoQuery filter = (IMongoQuery)builder.Eq("Locale_Reference", this.name + ".Airport");
            // var filter = builder.Where(flight => flight.Local_Reference == this.name + ".Airport");
            // var result = collection.Find(filter).ToList();
            // IMongoQuery filter = null;
            // filter = (IMongoQuery)new BsonDocument() {
            // {"Local_Reference", this.name + ".Airtport"}
            // };
           // var collection = db.GetCollection<Product>("products");
            // NOTE: p.Colors is of type string[]
            // var query = Query.EQ(p => p.Local_Reference, this.name + ".Airport");
            // MongoCursor r = collection.Find(query);
            // foreach (var r in result) {
            //     Debug.Log(r);
            // }
        }


        public void SetGazedAt(bool gazedAt)
        {
            if (gazedAt) {
                gazedAtMaterial.alpha = 0.75f;
            } else {
                gazedAtMaterial.alpha = 0.0f;
            }
        }
        public void SetClicked() {
            if (toggle.activeSelf) {
                toggle.SetActive(false);
            } else {
                toggle.SetActive(true);
            }
        }
        public void SearchResults() {

            //make a imongoquery use distinct location, query
            searchRes.SetActive(true);
            map.SetActive(false);
            // var collection = database.GetCollection<BsonDocument>("defective2018");
            // var builder = Builders<BsonDocument>.Filter;
            // IMongoQuery filter = (IMongoQuery)builder.Eq("Locale_Reference", this.name + ".Airport");
            // var result = collection.Find(filter).ToList();
            // int count = 0;
            // for (int i = 0; i < 400; i++) {

            //     count++;
            //     if (count == 10) break;
            // }
           for (int i = 0; i < 10; i++) {
                GameObject new1 = Instantiate(res, searchRes.transform.position, searchRes.transform.rotation);
                new1.transform.SetParent(searchRes.transform);
                Text flightname = new1.transform.Find("flightname").GetComponent<Text>();
                flightname.text = "1508049";
                Text details = new1.transform.Find("details").GetComponent<Text>();
                details.text = "ZZZ Airport \n B737";
           }

        }
        public void PullHolo() {
            holo.SetActive(true);
            mainscreen.SetActive(false);
            plane.SetActive(true);
        }
//         public void Reset()
//         {
//             int sibIdx = transform.GetSiblingIndex();
//             int numSibs = transform.parent.childCount;
//             for (int i = 0; i < numSibs; i++)
//             {
//                 GameObject sib = transform.parent.GetChild(i).gameObject;
//                 sib.transform.localPosition = startingPosition;
//                 sib.SetActive(i == sibIdx);
//             }
//         }

//         public void Recenter()
//         {
// #if !UNITY_EDITOR
//             GvrCardboardHelpers.Recenter();
// #else
//             if (GvrEditorEmulator.Instance != null)
//             {
//                 GvrEditorEmulator.Instance.Recenter();
//             }
// #endif  // !UNITY_EDITOR
//         }

//         public void TeleportRandomly(BaseEventData eventData)
//         {
//             // Only trigger on left input button, which maps to
//             // Daydream controller TouchPadButton and Trigger buttons.
//             PointerEventData ped = eventData as PointerEventData;
//             if (ped != null)
//             {
//                 if (ped.button != PointerEventData.InputButton.Left)
//                 {
//                     return;
//                 }
//             }

//             // Pick a random sibling, move them somewhere random, activate them,
//             // deactivate ourself.
//             int sibIdx = transform.GetSiblingIndex();
//             int numSibs = transform.parent.childCount;
//             sibIdx = (sibIdx + Random.Range(1, numSibs)) % numSibs;
//             GameObject randomSib = transform.parent.GetChild(sibIdx).gameObject;

//             // Move to random new location ±90˚ horzontal.
//             Vector3 direction = Quaternion.Euler(
//                 0,
//                 Random.Range(-90, 90),
//                 0) * Vector3.forward;

//             // New location between 1.5m and 3.5m.
//             float distance = 2 * Random.value + 1.5f;
//             Vector3 newPos = direction * distance;

//             // Limit vertical position to be fully in the room.
//             newPos.y = Mathf.Clamp(newPos.y, -1.2f, 4f);
//             randomSib.transform.localPosition = newPos;

//             randomSib.SetActive(true);
//             gameObject.SetActive(false);
//             SetGazedAt(false);
//         }
//     }
}
}
