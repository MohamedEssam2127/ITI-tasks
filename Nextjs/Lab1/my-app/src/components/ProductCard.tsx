import React from 'react'
import Image from 'next/image'
import { Product } from '@/services/productsAPI'

interface ProductCardProps {
  product: Product
}

export default function ProductCard({ product }: ProductCardProps) {
  return (
    <div className="card h-100 shadow-sm border-0">
      <div className="p-3" style={{ height: '200px', display: 'flex', alignItems: 'center', justifyContent: 'center' }}>
        <Image 
          src={product.image} 
          className="card-img-top" 
          alt={product.title} 
          width={200}
          height={200}
          style={{ maxHeight: '100%', maxWidth: '100%', objectFit: 'contain' }}
        />
      </div>
      <div className="card-body d-flex flex-column">
        <h5 className="card-title text-truncate" title={product.title}>{product.title}</h5>
        <p className="card-text text-muted small flex-grow-1">
          {product.description.substring(0, 80)}...
        </p>
        <div className="d-flex justify-content-between align-items-center mt-3">
          <span className="fw-bold text-primary">${product.price}</span>
          <button className="btn btn-sm btn-outline-primary">View Details</button>
        </div>
      </div>
    </div>
  )
}
