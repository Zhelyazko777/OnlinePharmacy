$('.childrenCategories').toggle();
$(() => {
    tinymce.init({ selector: '.editor' });
    let parents = document.getElementsByClassName('parent');

    for (var i = 0; i < parents.length; i++) {
        parents[i].addEventListener("click", function () {
            this.classList.toggle("active");
            var dropdownContent = this.nextElementSibling;
            if (dropdownContent.style.display === "block") {
                dropdownContent.style.display = "none";
            } else {
                dropdownContent.style.display = "block";
            }
        });
    }
})
