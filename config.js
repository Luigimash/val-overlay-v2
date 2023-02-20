var API_KEY = 'AIzaSyAuJtfvLL6QWw7cc345V8llTe5eMkhpan8';
var TIMER_ELEMENT = 'breakTimer';

/*PULLRATE is how often (ms) info from the google sheet will be pulled. Max 1000ms, as google will start rate limiting
 * past 60 calls/second. */
var PULLRATE = 2000;

var SPREADSHEETID = '1Tme3Jjw46wLTV_obzmON0FB1e7vEam3JZvo_Ocnd8Vc';
//update sheet name in the Range definitions

// Discovery doc URL for APIs used by the quickstart, it's apparently useful
const DISCOVERY_DOC = 'https://sheets.googleapis.com/$discovery/rest?version=v4';

const SIDECOLORSTXT = 'sideColors.txt';