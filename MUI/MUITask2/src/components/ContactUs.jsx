import { Stack, Typography, TextField, Button, Box } from "@mui/material";

export default function ContactUs() {
  return (
    <Stack
      sx={{
        px: { xs: 3, lg: 16 },
        pt: { xs: 4, md: 6 },
        pb: { xs: 8, md: 12 },
        boxSizing: 'border-box',
        alignItems: 'center',
        bgcolor: '#fbfbfb',
      }}
    >
      <Typography variant="h4" sx={{ fontWeight: 'bold', mb: 6, color: '#333' }}>
        Contact Us
      </Typography>
      
      <Stack 
        spacing={3} 
        sx={{ 
          width: '100%', 
        }}
      >
        <Box>
          <Typography variant="body2" sx={{ mb: 1, color: '#333' }}>Name</Typography>
          <TextField 
            fullWidth 
            size="small" 
            sx={{ bgcolor: '#fff', '& .MuiOutlinedInput-root': { borderRadius: 1 } }}
          />
        </Box>
        <Box>
          <Typography variant="body2" sx={{ mb: 1, color: '#333' }}>Email</Typography>
          <TextField 
            fullWidth 
            size="small" 
            sx={{ bgcolor: '#fff', '& .MuiOutlinedInput-root': { borderRadius: 1 } }}
          />
        </Box>
        <Box>
          <Typography variant="body2" sx={{ mb: 1, color: '#333' }}>Message</Typography>
          <TextField 
            fullWidth 
            multiline 
            rows={5} 
            sx={{ bgcolor: '#fff', '& .MuiOutlinedInput-root': { borderRadius: 1 } }}
          />
        </Box>
        <Box sx={{ display: 'flex', justifyContent: 'flex-start' }}>
          <Button 
            variant="contained" 
            color="primary"
            sx={{ textTransform: 'none', px: 4, py: 1 }}
          >
            Submit
          </Button>
        </Box>
      </Stack>
    </Stack>
  );
}
