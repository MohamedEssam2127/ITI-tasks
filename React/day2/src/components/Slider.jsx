import  { Component } from 'react'
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faArrowLeft, faArrowRight } from "@fortawesome/free-solid-svg-icons";
import '../styles/slider.css'
import img1  from '../assets/1.jpg'
import img2  from '../assets/2.jpeg'
import img3  from '../assets/3.jpeg'
import img4  from '../assets/4.webp'

export default class Slider extends Component {

 imgArr = [img1,img2,img3 ,img4]
state ={
  imgSrc :this.imgArr[0],
  index :0
}


  left = () => {
    this.setState((prevState) => {
      const newIndex = prevState.index === 0 ? this.imgArr.length - 1 : prevState.index - 1;
      return {
        index: newIndex,
        imgSrc: this.imgArr[newIndex]
      };
    });
  }

  right = () => {
    this.setState((prevState) => {
      const newIndex = prevState.index === this.imgArr.length - 1 ? 0 : prevState.index + 1;
      return {
        index: newIndex,
        imgSrc: this.imgArr[newIndex]
      };
    });
  }
    render() {
        return (
            <div className='slider-container'>
                <button className='slider-arrow' onClick={this.left} >
                    <FontAwesomeIcon icon={faArrowLeft} />
                </button>
                
                <div className='slider-image-wrapper'>
                    <img src={this.state.imgSrc} className='slider-img' />
                </div>

                <button className='slider-arrow' onClick={this.right} >
                    <FontAwesomeIcon icon={faArrowRight} />
                </button>
            </div>
        )
    }

}
