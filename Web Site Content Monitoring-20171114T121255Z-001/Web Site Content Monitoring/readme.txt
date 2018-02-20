Task

Monitor http://www.splunk.com/page/events/splunklive website and save the results in a csv file.
If new events are found send an email containing the new events.

Notes
All the activities are running in background. In order to do this we set the Headless property of the Browser to true.
Everything runs inside an error handling (Try-Catch) activity. If errors are received during the work flow execution we are notified  by an email.

Before running the workflow click arguments tab and set the following fields (emailFrom, emailTo) with your gmail data
Set your email password inside the three "Send Email" activities

Steps

1. Extract data from Splunk web site using the Web Scraping Wizard
2. Load old data from the csv file
3. Compare 2 data tables
4. If there are new results email them and append them to csv, otherwise send an email 
