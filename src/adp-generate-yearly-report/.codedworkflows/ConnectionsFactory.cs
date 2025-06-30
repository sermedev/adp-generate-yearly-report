using UiPath.CodedWorkflows;
using System;

namespace adpgenerateyearlyreport
{
    public class GoogleDocsFactory
    {
        public GoogleDocsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class DriveFactory
    {
        public DriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class GmailFactory
    {
        public UiPath.GSuite.Activities.Api.GmailConnection My_Workspace_rrpatestuser_gmail_com__2 { get; set; }
        public UiPath.GSuite.Activities.Api.GmailConnection PersonalFolder_rrpatestuser_gmail_com__3 { get; set; }

        public GmailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_rrpatestuser_gmail_com__2 = new UiPath.GSuite.Activities.Api.GmailConnection("9f1b09f3-59ff-458c-97e2-1975d7385e7c", resolver);
            PersonalFolder_rrpatestuser_gmail_com__3 = new UiPath.GSuite.Activities.Api.GmailConnection("18ba602b-e204-4826-ad2f-5931ef909906", resolver);
        }
    }

    public class GoogleSheetsFactory
    {
        public GoogleSheetsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }
}