export interface Product {
  id: number;
  title: string;
  price: number;
  description: string;
  category: string;
  image: string;

}

export const getAllProducts = async (): Promise<Product[]> => {
  const response = await fetch('https://fakestoreapi.com/products');
  if (!response.ok) {
    throw new Error('Failed to fetch products');
  }
  console.log(response);
  return response.json();
};

export const getProductsByCategory = async (category: string): Promise<Product[]> => {
  const response = await fetch(`https://fakestoreapi.com/products/category/${category}`);
  if (!response.ok) {
    throw new Error('Failed to fetch products for category: ' + category);
  }
  return response.json();
};
