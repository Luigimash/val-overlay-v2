var API_KEY = 'ENTER_API_KEY';
var TIMER_ELEMENT = 'breakTimer';

/*PULLRATE is how often (ms) info from the google sheet will be pulled. Max 1000ms, as google will start rate limiting
 * past 60 calls/second. */
var PULLRATE = 2000;

var SPREADSHEETID = 'ENTER_SPREADSHEET_ID';
//update sheet name in the Range definitions

// Discovery doc URL for APIs used by the quickstart, it's apparently useful
const DISCOVERY_DOC = 'https://sheets.googleapis.com/$discovery/rest?version=v4';

const SIDECOLORSTXT = 'sideColors.txt';