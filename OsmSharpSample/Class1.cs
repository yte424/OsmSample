﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;
//using System.Net;
//using System.Xml;
//using System.IO;
//using OsmSharp.Osm.Data.Processor;
//using OsmSharp.Osm.Data.XML.Processor;
//using OsmSharp.Osm.Data.XML;
//using OsmSharp.Osm.Simple;
//using System.Threading.Tasks;

//using OsmSharp.Osm;
//using OsmSharp.Osm.Core;
//using OsmSharp.Osm.Data.Core.Processor.Filter.Sort;
//using OsmSharp.Osm.Routing.Data.Processing;
//using OsmSharp.Osm.Routing.Interpreter;
//using OsmSharp.Routing;
//using OsmSharp.Routing.Core;
//using OsmSharp.Routing.Core.Graph.DynamicGraph.SimpleWeighed;
//using OsmSharp.Routing.Core.Graph.Memory;
//using OsmSharp.Routing.Core.Graph.Router.Dykstra;

//namespace OsmSharpSample
//{
//    class Class1
//    {
//        public  Class1()
//        {
//            /// <summary>
//            /// 
//            /// </summary>
//            //initialize the connection.
//            APIConnection api_instance = new APIConnection(
//            "http://api06.dev.openstreetmap.org/",
//            "osmsharp", "osmsharp");

//            // open a changeset.
//            long changeset_id = api_instance.ChangeSetOpen("An example comment!");

//            // initialize the nodes.
//            SimpleNode node1 = new SimpleNode();
//            node1.Latitude = -0.494497;
//            node1.Longitude = -24.119325;
//            node1.Tags = new Dictionary<string, string>();
//            node1.Tags.Add("type", "testnode1");
//            node1.Visible = true;
//            node1 = api_instance.NodeCreate(node1); // create
//            SimpleNode node2 = new SimpleNode();
//            node2.Latitude = -0.494497 + 0.0001f;
//            node2.Longitude = -24.119325 + 0.0001f;
//            node2.Tags = new Dictionary<string, string>();
//            node2.Tags.Add("type", "testnode2");
//            node2.Visible = true;
//            node2 = api_instance.NodeCreate(node2); // create

//            // initialize the way.
//            SimpleWay way = new SimpleWay();
//            way.Tags = new Dictionary<string, string>();
//            way.Tags.Add("type", "testway");
//            way.Nodes = new List<long>();
//            way.Visible = true;
//            way.Nodes.Add(node1.Id.Value);
//            way.Nodes.Add(node2.Id.Value);
//            way = api_instance.WayCreate(way); // create

//            // initialize the relation.
//            SimpleRelation relation = new SimpleRelation();
//            relation.Tags = new Dictionary<string, string>();
//            relation.Tags.Add("type", "testrelation");
//            relation.Members = new List<SimpleRelationMember>();
//            relation.Visible = true;
//            relation.Members.Add(new SimpleRelationMember()
//            {
//                MemberId = node1.Id.Value,
//                MemberRole = "some_nodes_role",
//                MemberType = SimpleRelationMemberType.Node
//            });
//            relation.Members.Add(new SimpleRelationMember()
//            {
//                MemberId = node2.Id.Value,
//                MemberRole = "some_nodes_role",
//                MemberType = SimpleRelationMemberType.Node
//            });
//            relation.Members.Add(new SimpleRelationMember()
//            {
//                MemberId = way.Id.Value,
//                MemberRole = "some_ways_role",
//                MemberType = SimpleRelationMemberType.Way
//            });

//            // save the relation.
//            relation = api_instance.RelationCreate(relation);

//            // close the changeset.
//            api_instance.ChangeSetClose();
//        }
//    }
//}
