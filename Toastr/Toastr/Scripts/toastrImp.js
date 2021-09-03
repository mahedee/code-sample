$(document).ready(function () {

    displayToastr();
 
});

function displayToastr() {
    //alert('yes');
    // Display a info toast, with no title
    toastr.info('Hi Mahedee, This information for you.')

    // Display a warning toast, with no title
    toastr.warning('Hi Mahedee, This the first warning for you!')

    // Display a success toast, with a title
    toastr.success('Yes! You have successfully completed your task!', 'Congratulation for you, Mahedee!')

    // Display an error toast, with a title
    toastr.error('An error occured in the solution!', 'Please contact with system administrator.')
}