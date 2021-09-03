app.value('pageMethods', PageMethods);

app.factory('student', function (pageMethods, $rootScope) {
    var result = [];
    pageMethods.GetStudent(function (data) {
        data.forEach(function (item) {
            result.push({ id: item.Id, name: item.Name, semester: item.Semester, credits: item.Credits});
        });
        $rootScope.$apply();
    });
    return result;
})
