const chatContainer = document.getElementById('chat-container');
const messageInput = document.getElementById('message-input');
const sendBtn = document.getElementById('send-btn');
const newChatBtn = document.getElementById('new-chat-btn');

//your api key here 
// const OPENAI_API_KEY = "";

let chatHistory = [{ "role": "developer", "content": "You are a helpful assistant." }];

function getTimestamp() {
  const now = new Date();
  return now.toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' });
}

function hideWelcome() {
  const existing = document.getElementById('welcome-state');
  if (existing && !existing.classList.contains('hidden')) {
    existing.classList.add('hidden');
    setTimeout(() => existing.remove(), 300);
  }
}

function showWelcome() {
  const existing = document.getElementById('welcome-state');
  if (existing) return;

  const state = document.createElement('div');
  state.classList.add('welcome-state');
  state.id = 'welcome-state';
  state.innerHTML = `
    <div class="welcome-icon">
      <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="1.5" stroke-linecap="round" stroke-linejoin="round"><circle cx="12" cy="12" r="10"/><path d="M9.09 9a3 3 0 0 1 5.83 1c0 2-3 3-3 3"/><path d="M12 17h.01"/></svg>
    </div>
    <h2 class="welcome-title">How can I help you today?</h2>
    <p class="welcome-sub">Ask me anything — I'm here to assist you.</p>
  `;
  chatContainer.appendChild(state);
}

function createBubble(role, content, isError = false) {
  const row = document.createElement('div');
  row.classList.add('message-row', role);

  const avatar = document.createElement('div');
  avatar.classList.add('avatar', role === 'user' ? 'user-avatar' : 'ai-avatar');
  avatar.textContent = role === 'user' ? 'U' : 'AI';

  const bubble = document.createElement('div');
  bubble.classList.add('bubble', role === 'user' ? 'user-bubble' : 'ai-bubble');
  if (isError) bubble.classList.add('error-bubble');

  if (content === 'thinking') {
    const indicator = document.createElement('div');
    indicator.classList.add('thinking-indicator');
    indicator.innerHTML = '<div class="dot"></div><div class="dot"></div><div class="dot"></div>';
    bubble.appendChild(indicator);
  } else {
    const text = document.createElement('p');
    text.textContent = content;
    bubble.appendChild(text);

    const timestamp = document.createElement('span');
    timestamp.classList.add('timestamp');
    timestamp.textContent = getTimestamp();
    bubble.appendChild(timestamp);
  }

  if (role === 'user') {
    row.appendChild(bubble);
    row.appendChild(avatar);
  } else {
    row.appendChild(avatar);
    row.appendChild(bubble);
  }

  return row;
}

function appendMessage(role, content, isError = false) {
  const bubble = createBubble(role, content, isError);
  bubble.classList.add('bubble-enter');
  chatContainer.appendChild(bubble);
  chatContainer.scrollTop = chatContainer.scrollHeight;

  requestAnimationFrame(() => {
    bubble.classList.add('bubble-visible');
  });
  
  return bubble;
}

function toggleInput(disabled) {
  messageInput.disabled = disabled;
  sendBtn.disabled = disabled;
}

async function fetchAIResponse() {
  const thinkingBubble = appendMessage('ai', 'thinking');
  toggleInput(true);

  try {
    const response = await fetch('https://api.openai.com/v1/chat/completions', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
        'Authorization': `Bearer ${OPENAI_API_KEY}`
      },
      // model name : gpt-5.4-mini is the free model 
      body: JSON.stringify({
        model: 'gpt-5.4-mini',
        messages: chatHistory
      })
    });

    const data = await response.json();
    thinkingBubble.remove();

    if (!response.ok) {
      throw new Error(data.error?.message || 'Failed to fetch response');
    }

    const aiMessage = data.choices[0].message.content;
    chatHistory.push({ role: 'assistant', content: aiMessage });
    appendMessage('ai', aiMessage);
  } catch (error) {
    thinkingBubble.remove();
    appendMessage('ai', error.message, true);
  } finally {
    toggleInput(false);
    messageInput.focus();
  }
}

function sendMessage() {
  const content = messageInput.value.trim();
  if (!content) return;

  hideWelcome();

  chatHistory.push({ role: 'user', content });
  appendMessage('user', content);
  
  messageInput.value = '';
  
  fetchAIResponse();
}

function clearChat() {
  chatHistory = [{ "role": "developer", "content": "You are a helpful assistant." }];
  chatContainer.innerHTML = '';
  showWelcome();
}

sendBtn.addEventListener('click', sendMessage);

messageInput.addEventListener('keydown', (e) => {
  if (e.key === 'Enter' && !e.shiftKey) {
    e.preventDefault();
    if (!sendBtn.disabled) sendMessage();
  }
});

newChatBtn.addEventListener('click', clearChat);
