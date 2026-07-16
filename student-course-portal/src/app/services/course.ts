import { Injectable } from '@angular/core';
import { Course } from '../models/course.model';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  private courses: Course[] = [
    {
      id: 1,
      name: 'Angular',
      code: 'ANG101',
      credits: 4,
      gradeStatus: 'passed'
    },
    {
      id: 2,
      name: 'ASP.NET Core',
      code: 'NET201',
      credits: 4,
      gradeStatus: 'pending'
    },
    {
      id: 3,
      name: 'Microservices',
      code: 'MIC301',
      credits: 3,
      gradeStatus: 'passed'
    },
    {
      id: 4,
      name: 'Entity Framework Core',
      code: 'EF401',
      credits: 4,
      gradeStatus: 'failed'
    },
    {
      id: 5,
      name: 'SQL Server',
      code: 'SQL501',
      credits: 3,
      gradeStatus: 'passed'
    }
  ];

  getCourses(): Course[] {
    return this.courses;
  }

  getCourseById(id: number): Course | undefined {
    return this.courses.find(course => course.id === id);
  }

  addCourse(course: Course): void {
    this.courses.push(course);
  }

}