import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CourseApi } from './course-api';

describe('CourseApi', () => {
  let component: CourseApi;
  let fixture: ComponentFixture<CourseApi>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CourseApi],
    }).compileComponents();

    fixture = TestBed.createComponent(CourseApi);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
