var gulp = require('gulp');
const sass = require('gulp-sass')(require('sass'));




gulp.task('compilar-sass', function(done) {
    // Ruta SCSS
    gulp.src('source/sass/main.scss')  
    .pipe(sass().on('error', sass.logError))
    // Ruta del CSS
    .pipe(gulp.dest('css')); 
    done();
});


gulp.task( 'watch', function() {
    gulp.watch( [
       'source/*/*.scss',
        'source/sass/*.scss'], gulp.series('compilar-sass') );
});

