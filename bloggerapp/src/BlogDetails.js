import React from "react";

function BlogDetails() {
  const blogs = [
    { id: 1, title: "React Basics" },
    { id: 2, title: "Understanding JSX" },
    { id: 3, title: "Conditional Rendering" }
  ];

  return (
    <div>
      <h2>Blog Details</h2>

      <ul>
        {blogs.map(blog => (
          <li key={blog.id}>{blog.title}</li>
        ))}
      </ul>
    </div>
  );
}

export default BlogDetails;