import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { CourseList } from '../course-list/course-list';
import { CourseSummary } from '../course-summary/course-summary';
import { StudentProfile } from '../student-profile/student-profile';
import { ReactiveEnrollmentForm } from '../reactive-enrollment-form/reactive-enrollment-form';
import { CourseApi } from '../course-api/course-api';

import { CourseService } from '../../services/course';

@Component({
  selector: 'app-home',
  imports: [
    FormsModule,
    CourseList,
    CourseSummary,
    StudentProfile,
    ReactiveEnrollmentForm,
    CourseApi
  ],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home implements OnInit, OnDestroy {

  portalName = 'Student Course Portal';

  isPortalActive = true;

  message = '';

  searchTerm = '';

  coursesAvailable = 0;

  selectedCourse = 'Angular Fundamentals';

  constructor(private courseService: CourseService) {}

  ngOnInit(): void {
    this.coursesAvailable = this.courseService.getCourses().length;
  }

  ngOnDestroy(): void {
    console.log('HomeComponent destroyed');
  }

  onEnrollClick() {
    this.message = 'Enrollment opened!';
  }
}