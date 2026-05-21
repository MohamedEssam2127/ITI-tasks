import { Component } from 'react'
import '../styles/InputForm.css'

export class InputForm extends Component {

  render() {
    return (
      <section className="news-form-section">
        <h3 className="section-title" style={{ visibility: "hidden" }}>Spacer</h3>
        <form className="custom-form">
          <h3 className="section-title">Post a News Update</h3>

          <div className="form-row">
            <div className="form-group">
              <label className="form-label">Title</label>
              <input type="text" className="custom-input" />
            </div>

            <div className="form-group">
              <label className="form-label">Category</label>
              <input type="text" className="custom-input" />
            </div>
          </div>

          <div className="form-group">
            <label className="form-label">Description</label>
            <textarea className="custom-input no-resize" rows="5"></textarea>
          </div>

          <button className="btn-primary" type="button">
            Publish News
          </button>
        </form>
      </section>
    )
  }

}