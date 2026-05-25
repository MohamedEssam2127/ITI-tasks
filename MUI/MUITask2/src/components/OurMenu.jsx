import { Typography, Stack, Grid, Card, CardMedia, CardContent } from "@mui/material";

const menuItems = [
  {
    title: "Grilled Salmon",
    description: "Freshly grilled salmon with herbs.",
    price: "$15.99",
    image: "https://images.unsplash.com/photo-1485921325833-c519f76c4927?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
  },
  {
    title: "Pasta Carbonara",
    description: "Creamy pasta with bacon and cheese.",
    price: "$12.99",
    image: "https://images.unsplash.com/photo-1612874742237-6526221588e3?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
  },
  {
    title: "Cheesecake",
    description: "Classic New York-style cheesecake.",
    price: "$7.99",
    image: "https://images.unsplash.com/photo-1533134242443-d4fd215305ad?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
  }, {
    title: "Steak Frites",
    description: "Juicy steak served with crispy french fries.",
    price: "$24.99",
    image: "https://images.unsplash.com/photo-1600891964092-4316c288032e?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
  },
  {
    title: "Margherita Pizza",
    description: "Classic pizza with fresh mozzarella and basil.",
    price: "$14.99",
    image: "https://images.unsplash.com/photo-1574071318508-1cdbab80d002?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
  },
  {
    title: "Caesar Salad",
    description: "Crisp romaine lettuce with Caesar dressing and croutons.",
    price: "$9.99",
    image: "https://images.unsplash.com/photo-1550304943-4f24f54ddde9?ixlib=rb-4.0.3&auto=format&fit=crop&w=600&q=80"
  }
];

export default function OurMenu() {
  return (
    <Stack
      sx={{
        px: { xs: 2 , lg: 6 },
        py: { xs: 8, md: 10 },
        alignItems: 'center',
        bgcolor: '#ffffff',
      }}
    >
      <Typography variant="h4" sx={{ fontWeight: 'bold', mb: 6, color: '#333' }}>
        Our Menu
      </Typography>

      <Grid container spacing={4}  sx ={{justifyContent:'center'}}>
        {menuItems.map((item, index) => (
          <Grid item xs={12} md={4} key={index}>
            <Card sx={{ boxShadow: 3, borderRadius: 2, height: '100%', display: 'flex', flexDirection: 'column',width:350 }}>
              <CardMedia
                component="img"
                sx={{ height: { xs: 180, sm: 200, md: 220 }, objectFit: 'cover' }}
                image={item.image}
                alt={item.title}
              />
              <CardContent sx={{ textAlign: 'left', flexGrow: 1, display: 'flex', flexDirection: 'column' }}>
                <Typography variant="subtitle1" sx={{ fontWeight: 'bold', mb: 1, color: '#333' }}>
                  {item.title}
                </Typography>
                <Typography variant="body2" sx={{ color: '#555', mb: 2, flexGrow: 1 }}>
                  {item.description}
                </Typography>
                <Typography variant="subtitle2" sx={{ fontWeight: 'bold', color: '#111' }}>
                  {item.price}
                </Typography>
              </CardContent>
            </Card>
          </Grid>
        ))}
      </Grid>
    </Stack>
  );
}
