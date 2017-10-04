function myFunction() {
    var frmvalidator = new Validator("myform");

    //if (document.getElementById('Number').value > 1000) {
    //    "Insert value less than 1000"
    //    e.preventDefault();

    //}
    window.open("http://localhost:9915/FizzBuzz/DisplayForm?input=" + document.getElementById('Number').value);
}