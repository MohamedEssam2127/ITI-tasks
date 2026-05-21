import { getAllProducts } from '@/services/productsAPI'
import React from 'react'
import ProductCard from '@/components/ProductCard'

export default async function page() {
  const products = await getAllProducts();
  return (
    <div className="container py-5">
      <h1 className="mb-4 text-center fw-bold">Our Products</h1>
      <div className="row g-4">
        {products.map((product) => (
          <div key={product.id} className="col-md-4 col-lg-3">
            <ProductCard product={product} />
          </div>
        ))}
      </div>
    </div>
  )
}


