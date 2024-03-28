import React, { useEffect, useState } from "react";
import MyCarousel from "./MyCarousel";
import { useCookies } from "react-cookie";
import Slider from "react-slick";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";
import ProductCard from "./ProductCard";
import config from '../config.json';

export default function Home() {
  const [cookies, setCookie] = useCookies(["user"]);
  const [products, setProducts] = useState([]);
  const [trending, setTrending] = useState([]);

  // http://localhost:5049/api/Product/get

  useEffect(() => {
    fetch(`http://localhost:${config.port}/api/Product/get`)
      .then((res) => res.json())
      .then((data) => {
        setProducts(data);
      });
  }, []);

  useEffect(() => {
    fetch(`http://localhost:${config.port}/api/Invoice/trending`)
      .then((res) => res.json())
      .then((data) => {
        setTrending(data);
      });
  }, []);

  var settings = {
    dots: true,
    infinite: true,
    speed: 500,
    slidesToShow: 4,
    slidesToScroll: 4,
  };

  return (
    <div>
      <MyCarousel />
      <h1
        style={{
          fontFamily: "Montserrat,sans-serif",
          display: "flex",
          justifyContent: "center",
          padding: "30px",
        }}
      >
        Trending
      </h1>
      <Slider {...settings}>
        {products.filter(product => trending.includes(product.productId)).map((product) => (
          <ProductCard key={product.productId} product={product} />
        ))}
      </Slider>
    </div>
  );
}
