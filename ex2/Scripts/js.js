/**
 * A handler function for search form submission.
 */
function submit_search() {
	return isValidEmail(document.getElementById("email_addr").value);
}

/**
 * Validate email addresss.
  */
function isValidEmail(email) {
    var re = /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/;
    return re.test(email);
}