import { Box, Typography, Button } from "@mui/material";

function CTASection() {
  return (
    <Box
      sx={{
        display: "block",
        textAlign: "center",
        background: "linear-gradient(to right, #9c27b0, #e91e63)",
        padding: "80px 20px",
        width: "100%",
        boxSizing: "border-box"
      }}
    >
      <Typography
        variant="h4"
        sx={{
          display: "block",
          color: "white",
          fontWeight: "bold",
          marginBottom: "30px"
        }}
      >
        Ready to build something awesome?
      </Typography>
      <Button
        variant="contained"
        sx={{
          display: "inline-block",
          backgroundColor: "black",
          color: "white",
          padding: "12px 30px",
          fontSize: "18px",
          fontWeight: "bold",
          "&:hover": {
            backgroundColor: "#333"
          }
        }}
      >
        JOIN NOW 🚀
      </Button>
    </Box>
  );
}

export default CTASection;
