import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CourseService } from '../../services/course';

@Component({
  selector: 'app-course-summary',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './course-summary.html',
  styleUrl: './course-summary.css'
})
export class CourseSummary implements OnInit {

  totalCourses = 0;

  constructor(private courseService: CourseService) {}

  ngOnInit(): void {
    this.totalCourses = this.courseService.getCourses().length;
  }

}