import { getAllProducts } from '@/services/productsAPI'
import React from 'react'
import ProductCard from '@/components/ProductCard'

export const metadata = {
  title: "All Products",
};

export default async function AllCategoryPage() {
  const products = await getAllProducts();
  return (
    <div>
      <h1 className="mb-4 fw-bold">All Products</h1>
      <div className="row g-4">
        {products.map((product) => (
          <div key={product.id} className="col-md-6 col-lg-4">
            <ProductCard product={product} />
          </div>
        ))}
      </div>
    </div>
  )
}
