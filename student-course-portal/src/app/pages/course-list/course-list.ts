import { Component, Input, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

import { Course } from '../../models/course.model';
import { CourseService } from '../../services/course';

@Component({
  selector: 'app-course-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseList implements OnInit {

  @Input()
  courseName: string = '';

  courses: Course[] = [];

  constructor(private courseService: CourseService) {}

  ngOnInit(): void {
    this.courses = this.courseService.getCourses();
  }

}