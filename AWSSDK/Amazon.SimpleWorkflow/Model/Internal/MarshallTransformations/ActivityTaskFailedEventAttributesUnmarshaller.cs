/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */ 
    using System;
    using System.Collections.Generic; 
    using Amazon.SimpleWorkflow.Model; 
    using Amazon.Runtime.Internal.Transform; 

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// ActivityTaskFailedEventAttributesUnmarshaller 
      /// </summary> 
      internal class ActivityTaskFailedEventAttributesUnmarshaller : IUnmarshaller<ActivityTaskFailedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<ActivityTaskFailedEventAttributes, JsonUnmarshallerContext> 
      { 
        ActivityTaskFailedEventAttributes IUnmarshaller<ActivityTaskFailedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public ActivityTaskFailedEventAttributes Unmarshall(JsonUnmarshallerContext context) 
        { 
          ActivityTaskFailedEventAttributes activityTaskFailedEventAttributes = new ActivityTaskFailedEventAttributes();
          
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("Reason", targetDepth)) 
              {
                activityTaskFailedEventAttributes.Reason = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Details", targetDepth)) 
              {
                activityTaskFailedEventAttributes.Details = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ScheduledEventId", targetDepth)) 
              {
                activityTaskFailedEventAttributes.ScheduledEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("StartedEventId", targetDepth)) 
              {
                activityTaskFailedEventAttributes.StartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return activityTaskFailedEventAttributes; 
            } 
          } 
          return activityTaskFailedEventAttributes; 
        } 
        
        private static ActivityTaskFailedEventAttributesUnmarshaller instance; 
        public static ActivityTaskFailedEventAttributesUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new ActivityTaskFailedEventAttributesUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
